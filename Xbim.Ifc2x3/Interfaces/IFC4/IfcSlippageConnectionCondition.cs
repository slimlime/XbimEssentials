// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralLoadResource
{
	public partial class @IfcSlippageConnectionCondition : IIfcSlippageConnectionCondition
	{
		Xbim.Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageX 
		{ 
			get
			{
				if (SlippageX == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLengthMeasure((double)SlippageX);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageY 
		{ 
			get
			{
				if (SlippageY == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLengthMeasure((double)SlippageY);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageZ 
		{ 
			get
			{
				if (SlippageZ == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLengthMeasure((double)SlippageZ);
			} 
		}
	}
}