# XML Tools plugin
[![Auto build](https://github.com/DKorablin/Plugin.Tools.Xml/actions/workflows/release.yml/badge.svg)](https://github.com/DKorablin/Plugin.Tools.Xml/releases/latest)

When working with data in XML format you have to deal with validation, selecting and data transformation. There are a lot of tools for performing these operations while they provide much more functionality than the current plugin but it's more than enough to perform simple and routine tasks.

It's designed to check XSLT conversion on XML data. In the upper window you need to place XSLT and in bottom - XML and press the only button on the toolBar.

With this tool you can validate XPath selector and test in on data in XML format. Upper textBox is intended for XPath (MRUх10), lower textBox is intended for data in XML format. When you clicked on the only button in the toolBar we get the result of the selection through XPath in the right window.

Unlike simple testing of data in XSD format the window allows you to generate XSD (using standard .NET tools) which complains data structure in XML format.