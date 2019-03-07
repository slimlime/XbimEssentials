// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceOfLinearExtrusion
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceOfLinearExtrusion : IIfcSweptSurface
	{
		IIfcDirection @ExtrudedDirection { get;  set; }
		IfcLengthMeasure @Depth { get;  set; }
		Common.Geometry.XbimVector3D @ExtrusionAxis  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcSurfaceOfLinearExtrusion", 256)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceOfLinearExtrusion : IfcSweptSurface, IInstantiableEntity, IIfcSurfaceOfLinearExtrusion, IContainsEntityReferences, IEquatable<@IfcSurfaceOfLinearExtrusion>
	{
		#region IIfcSurfaceOfLinearExtrusion explicit implementation
		IIfcDirection IIfcSurfaceOfLinearExtrusion.ExtrudedDirection { 
 
 
			get { return @ExtrudedDirection; } 
			set { ExtrudedDirection = value as IfcDirection;}
		}	
		IfcLengthMeasure IIfcSurfaceOfLinearExtrusion.Depth { 
 
			get { return @Depth; } 
			set { Depth = value;}
		}	
		Common.Geometry.XbimVector3D IIfcSurfaceOfLinearExtrusion.@ExtrusionAxis  { get { return @ExtrusionAxis; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceOfLinearExtrusion(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _extrudedDirection;
		private IfcLengthMeasure _depth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcDirection @ExtrudedDirection 
		{ 
			get 
			{
				if(_activated) return _extrudedDirection;
				Activate();
				return _extrudedDirection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _extrudedDirection = v, _extrudedDirection, value,  "ExtrudedDirection", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLengthMeasure @Depth 
		{ 
			get 
			{
				if(_activated) return _depth;
				Activate();
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth", 4);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public Common.Geometry.XbimVector3D @ExtrusionAxis 
		{
			get 
			{
				//## Getter for ExtrusionAxis
			    return new Common.Geometry.XbimVector3D(
			        _extrudedDirection.X*_depth,
			        _extrudedDirection.Y*_depth,
			        _extrudedDirection.Z*_depth);
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_extrudedDirection = (IfcDirection)(value.EntityVal);
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceOfLinearExtrusion other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SweptCurve != null)
					yield return @SweptCurve;
				if (@Position != null)
					yield return @Position;
				if (@ExtrudedDirection != null)
					yield return @ExtrudedDirection;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}