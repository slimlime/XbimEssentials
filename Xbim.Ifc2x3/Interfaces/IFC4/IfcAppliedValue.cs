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
namespace Xbim.Ifc2x3.CostResource
{
	public partial class @IfcAppliedValue : IIfcAppliedValue
	{
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcAppliedValue.Name 
		{ 
			get
			{
				if (Name == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)Name);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcAppliedValue.Description 
		{ 
			get
			{
				if (Description == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)Description);
			} 
		}
		Xbim.Ifc4.CostResource.IfcAppliedValueSelect IIfcAppliedValue.AppliedValue 
		{ 
			get
			{
				if (AppliedValue == null) return null;
				if (AppliedValue is Xbim.Ifc2x3.MeasureResource.IfcRatioMeasure) 
					return new Xbim.Ifc4.MeasureResource.IfcRatioMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcRatioMeasure)AppliedValue);
				var ifcmeasurewithunit = AppliedValue as Xbim.Ifc2x3.MeasureResource.IfcMeasureWithUnit;
				if (ifcmeasurewithunit != null) 
					return ifcmeasurewithunit;
				if (AppliedValue is Xbim.Ifc2x3.MeasureResource.IfcMonetaryMeasure) 
					return new Xbim.Ifc4.MeasureResource.IfcMonetaryMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMonetaryMeasure)AppliedValue);
				return null;
			} 
		}
		IIfcMeasureWithUnit IIfcAppliedValue.UnitBasis 
		{ 
			get
			{
				return UnitBasis as IIfcMeasureWithUnit;
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDate? IIfcAppliedValue.ApplicableDate 
		{ 
			get
			{
				//TODO: Handle return of ApplicableDate for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDate? IIfcAppliedValue.FixedUntilDate 
		{ 
			get
			{
				//TODO: Handle return of FixedUntilDate for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcAppliedValue.Category 
		{ 
			get
			{
				//TODO: Handle return of Category for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcAppliedValue.Condition 
		{ 
			get
			{
				//TODO: Handle return of Condition for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.CostResource.IfcArithmeticOperatorEnum? IIfcAppliedValue.ArithmeticOperator 
		{ 
			get
			{
				//TODO: Handle return of ArithmeticOperator for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IEnumerable<IIfcAppliedValue> IIfcAppliedValue.Components 
		{ 
			get
			{
				//TODO: Handle return of Components for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcAppliedValue.HasExternalReference 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
	}
}