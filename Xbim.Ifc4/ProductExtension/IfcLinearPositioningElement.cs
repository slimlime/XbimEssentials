// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLinearPositioningElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLinearPositioningElement : IIfcPositioningElement
	{
		IIfcCurve @Axis { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcLinearPositioningElement", 1350)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcLinearPositioningElement : IfcPositioningElement, IIfcLinearPositioningElement, IEquatable<@IfcLinearPositioningElement>
	{
		#region IIfcLinearPositioningElement explicit implementation
		IIfcCurve IIfcLinearPositioningElement.Axis { 
 
 
			get { return @Axis; } 
			set { Axis = value as IfcCurve;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLinearPositioningElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurve _axis;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 21)]
		public IfcCurve @Axis 
		{ 
			get 
			{
				if(_activated) return _axis;
				Activate();
				return _axis;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axis = v, _axis, value,  "Axis", 8);
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_axis = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLinearPositioningElement other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}