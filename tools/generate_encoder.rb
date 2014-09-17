#!/usr/bin/env ruby

require 'nokogiri'

file = ARGV[0]
outfile = ARGV[1]

class Generator
  def initialize(filename)
    @doc = Nokogiri::XML(File.open(filename))
    @root = @doc.root
    @pkgs = @root.xpath("packages/packageDefine")
    @tids = {}
    tids = @root.xpath("tids/tidDefine")
    tids.each do |tid|
      tname = tid.attributes['name'].value
      val = tid.attributes['value'].value
      @tids[tname] = val
    end
    @fields = @root.xpath("fields/fieldDefine")

    @items = {}
    @root.xpath("items/itemDefine").each do |item|
      name = item.attributes['name'].value
      type = item.attributes['type'].value
      comment = item.attributes['comment'].value
      @items[name] = { name: name, type: type, comment: comment }
    end
    @types = @root.xpath("types/typeDefine")
  end

  def with_namespace(ns)
    out = "using System;\nusing System.ComponentModel;\n\n"
    out += "namespace #{ns}\n"
    out += "{\n"
    out += generate_type_classes
    out += generate_item_classes
    out += generate_packet_classes
    out += generate_field_classes

    out += "}\n"
    out
  end

  def generate_type_classes
    out = ""
    @types.each do |t|
      clname = t.attributes['name'].value
      base_type = t.attributes['baseType'].value
      length = t.attributes['length'].value
      precision = t.attributes['precision'].value

      # FTDFloatType, FTDNumberType, FTDStringType have length and precision included in the names.
      m = /^(?<base_type>FTDFloatType|FTDNumberType|FTDStringType)/.match(base_type)
      if m
        base_type = m["base_type"]
      end

      class_text =
          <<HERE
    public class #{clname} : #{base_type}
    {
        public override int Length
        {
            get
            {
                return #{length};
            }
        }

        public override int Precision
        {
            get
            {
                return #{precision};
            }
        }
    }

HERE
      out += class_text
    end
    out
  end

  def generate_item_classes
    @items.each do |item|

    end
    ""
  end

  def generate_packet_classes
    out = ""
    @pkgs.each do |pkg|
      pkg_name = pkg.attributes['name'].value
      tid = pkg.attributes['tid'].value
      tid_value = @tids[tid]
      model = pkg.attributes['model'].value
      comment = pkg.attributes['comment'].value

      class_text =
<<HERE
    [Description("#{comment}"), Category("#{model}")]
    public class #{pkg_name} : Packet
    {
        public override ushort TId
        {
            get
            {
                return #{tid_value};
            }
        }
    }

HERE
      out += class_text
    end
    out
  end

  def generate_field_classes
    out = ""
    @fields.each do |field|
      field_name = field.attributes['name'].value
      fid = field.attributes['fid'].value
      fv = field.attributes['fidValue'].value
      comment = field.attributes['comment'].value

      fileds_text = ""
      field.xpath('item').each do |item|
        item_def = @items[item.attributes['name'].value]
        item_name = item_def[:name]
        item_type = item_def[:type]
        item_comment = item_def[:comment] # equal? item.attributes['item_comment'].value
        fileds_text += "        [Description(\"#{item_comment}\")]\n        public #{item_type} #{item_name};\n\n"
      end

      class_text =
          <<HERE
    [Description("#{comment}")]
    public class #{field_name} : Field
    {
#{fileds_text}
        public override ushort FidValue
        {
            get
            {
                return #{fv};
            }
        }
    }

HERE
      out += class_text
    end
    out
  end
  def run
    with_namespace("FtdEncoder.Messages")
  end
end

g = Generator.new file
out = g.run

File.open(outfile, 'w') { |f| f.write(out) }