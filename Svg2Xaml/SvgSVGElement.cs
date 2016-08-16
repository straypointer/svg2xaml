////////////////////////////////////////////////////////////////////////////////
//
//  SvgSVGElement.cs - This file is part of Svg2Xaml.
//
//    Copyright (C) 2009,2011 Boris Richter <himself@boris-richter.net>
//
//  --------------------------------------------------------------------------
//
//  Svg2Xaml is free software: you can redistribute it and/or modify it under 
//  the terms of the GNU Lesser General Public License as published by the 
//  Free Software Foundation, either version 3 of the License, or (at your 
//  option) any later version.
//
//  Svg2Xaml is distributed in the hope that it will be useful, but WITHOUT 
//  ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
//  FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public 
//  License for more details.
//  
//  You should have received a copy of the GNU Lesser General Public License 
//  along with Svg2Xaml. If not, see <http://www.gnu.org/licenses/>.
//
//  --------------------------------------------------------------------------
//
//  $LastChangedRevision$
//  $LastChangedDate$
//  $LastChangedBy$
//
////////////////////////////////////////////////////////////////////////////////
using System.Xml.Linq;

namespace Svg2Xaml
{
  
  //****************************************************************************
  /// <summary>
  ///   Represents an &lt;svg&gt; element.
  /// </summary>
  class SvgSVGElement
    : SvgDrawableContainerBaseElement
  {
    //==========================================================================
    public SvgSVGElement(SvgDocument document, SvgBaseElement parent, XElement svgElement)
      : base(document, parent, svgElement)
    {
      // ...
		  XAttribute width_attribute = svgElement.Attribute("width");
		  if (width_attribute != null)
			  this.Width = SvgLength.Parse(width_attribute.Value);

		  XAttribute height_attribute = svgElement.Attribute("height");
		  if (height_attribute != null)
			  this.Height = SvgLength.Parse(height_attribute.Value);
    }

	public SvgLength Height { get; private set; }
	public SvgLength Width { get; private set; }

  } // class SvgSVGElement

}
