// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.TopologyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextureMap
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureMap : IIfcTextureCoordinate
	{
		IEnumerable<IIfcTextureVertex> @Vertices { get; }
		IIfcFace @MappedTo { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcTextureMap", 734)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureMap : IfcTextureCoordinate, IInstantiableEntity, IIfcTextureMap, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTextureMap>
	{
		#region IIfcTextureMap explicit implementation
		IEnumerable<IIfcTextureVertex> IIfcTextureMap.Vertices { get { return @Vertices; } }	
		IIfcFace IIfcTextureMap.MappedTo { get { return @MappedTo; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureMap(IModel model) : base(model) 		{ 
			Model = model; 
			_vertices = new ItemSet<IfcTextureVertex>( this, 0,  2);
		}

		#region Explicit attribute fields
		private ItemSet<IfcTextureVertex> _vertices;
		private IfcFace _mappedTo;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 3, -1, 2)]
		public ItemSet<IfcTextureVertex> @Vertices 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vertices;
				((IPersistEntity)this).Activate(false);
				return _vertices;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcFace @MappedTo 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mappedTo;
				((IPersistEntity)this).Activate(false);
				return _mappedTo;
			} 
			set
			{
				SetValue( v =>  _mappedTo = v, _mappedTo, value,  "MappedTo", 3);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_vertices.InternalAdd((IfcTextureVertex)value.EntityVal);
					return;
				case 2: 
					_mappedTo = (IfcFace)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureMap other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextureMap
            var root = (@IfcTextureMap)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextureMap left, @IfcTextureMap right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextureMap left, @IfcTextureMap right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Maps)
					yield return entity;
				foreach(var entity in @Vertices)
					yield return entity;
				if (@MappedTo != null)
					yield return @MappedTo;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Maps)
					yield return entity;
				if (@MappedTo != null)
					yield return @MappedTo;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}