#!/usr/bin/env ruby

require 'nokogiri'

file = ARGV[0]
outfile = ARGV[1]

def with_namespace(ns)
  out = "namespace #{ns}\n"
  out += "{\n"
  yield out
  out += "}\n"
end

def with_public_class(name)
  out = "pulbic class #{name}\n"
  out += "{\n"
  yield out
  out += "}\n"
end


File.open(file) do |f|
  doc = Nokogiri::XML(f)
  root = doc.root
  pkgs = root.xpath("packages/packageDefine")
  tids = root.xpath("tids/tidDefine")
  fields = root.xpath("fields/fieldDefine")
  items = root.xpath("items/itemDefine")
  types = root.xpath("types/typeDefine")
  puts pkgs.count
  puts tids.count
  puts fields.count
  puts items.count
  puts types.count
  out = ""
  out += with_namespace("Ftd") do |o|
    o += "puhh"
  end
  puts out
end
