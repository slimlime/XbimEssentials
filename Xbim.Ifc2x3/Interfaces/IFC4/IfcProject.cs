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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcProject : IIfcProject
	{
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcContext.ObjectType 
		{ 
			get
			{
				//TODO: Handle return of ObjectType for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcContext.LongName 
		{ 
			get
			{
				//TODO: Handle return of LongName for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcContext.Phase 
		{ 
			get
			{
				//TODO: Handle return of Phase for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IEnumerable<IIfcRepresentationContext> IIfcContext.RepresentationContexts 
		{ 
			get
			{
				//TODO: Handle return of RepresentationContexts for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IIfcUnitAssignment IIfcContext.UnitsInContext 
		{ 
			get
			{
				//TODO: Handle return of UnitsInContext for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IEnumerable<IIfcRelDefinesByProperties> IIfcContext.IsDefinedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByProperties>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		IEnumerable<IIfcRelDeclares> IIfcContext.Declares 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDeclares>(e => (e.RelatingContext as IfcProject) == this);
			} 
		}
	}
}