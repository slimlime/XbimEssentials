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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcSpaceType : IIfcSpaceType
	{
		Xbim.Ifc4.ProductExtension.IfcSpaceTypeEnum IIfcSpaceType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.ProductExtension.IfcSpaceTypeEnum.USERDEFINED:
						return Xbim.Ifc4.ProductExtension.IfcSpaceTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.ProductExtension.IfcSpaceTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.ProductExtension.IfcSpaceTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcSpaceType.LongName 
		{ 
			get
			{
				//TODO: Handle return of LongName for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcSpatialElementType.ElementType 
		{ 
			get
			{
				//TODO: Handle return of ElementType for which no match was found
				throw new System.NotImplementedException();
			} 
		}
	}
}