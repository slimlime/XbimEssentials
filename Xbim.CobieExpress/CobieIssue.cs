// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieIssue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieIssue : ICobieReferencedObject
	{
		string @Name { get; }
		string @Description { get; }
		ICobieIssueType @IssueType { get; }
		ICobieIssueRisk @Risk { get; }
		ICobieIssueChance @Chance { get; }
		ICobieIssueImpact @Impact { get; }
		ICobieContact @Owner { get; }
		string @Mitigation { get; }
		ICobieAsset @Causing { get; }
		ICobieAsset @Affected { get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Issue", 32)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieIssue : CobieReferencedObject, IInstantiableEntity, ICobieIssue, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@CobieIssue>
	{
		#region ICobieIssue explicit implementation
		string ICobieIssue.Name { get { return @Name; } }	
		string ICobieIssue.Description { get { return @Description; } }	
		ICobieIssueType ICobieIssue.IssueType { get { return @IssueType; } }	
		ICobieIssueRisk ICobieIssue.Risk { get { return @Risk; } }	
		ICobieIssueChance ICobieIssue.Chance { get { return @Chance; } }	
		ICobieIssueImpact ICobieIssue.Impact { get { return @Impact; } }	
		ICobieContact ICobieIssue.Owner { get { return @Owner; } }	
		string ICobieIssue.Mitigation { get { return @Mitigation; } }	
		ICobieAsset ICobieIssue.Causing { get { return @Causing; } }	
		ICobieAsset ICobieIssue.Affected { get { return @Affected; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieIssue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobieIssueType _issueType;
		private CobieIssueRisk _risk;
		private CobieIssueChance _chance;
		private CobieIssueImpact _impact;
		private CobieContact _owner;
		private string _mitigation;
		private CobieAsset _causing;
		private CobieAsset _affected;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public string @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public string @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public CobieIssueType @IssueType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _issueType;
				((IPersistEntity)this).Activate(false);
				return _issueType;
			} 
			set
			{
				SetValue( v =>  _issueType = v, _issueType, value,  "IssueType", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public CobieIssueRisk @Risk 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _risk;
				((IPersistEntity)this).Activate(false);
				return _risk;
			} 
			set
			{
				SetValue( v =>  _risk = v, _risk, value,  "Risk", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public CobieIssueChance @Chance 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _chance;
				((IPersistEntity)this).Activate(false);
				return _chance;
			} 
			set
			{
				SetValue( v =>  _chance = v, _chance, value,  "Chance", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public CobieIssueImpact @Impact 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impact;
				((IPersistEntity)this).Activate(false);
				return _impact;
			} 
			set
			{
				SetValue( v =>  _impact = v, _impact, value,  "Impact", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public CobieContact @Owner 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _owner;
				((IPersistEntity)this).Activate(false);
				return _owner;
			} 
			set
			{
				SetValue( v =>  _owner = v, _owner, value,  "Owner", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public string @Mitigation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mitigation;
				((IPersistEntity)this).Activate(false);
				return _mitigation;
			} 
			set
			{
				SetValue( v =>  _mitigation = v, _mitigation, value,  "Mitigation", 13);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public CobieAsset @Causing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _causing;
				((IPersistEntity)this).Activate(false);
				return _causing;
			} 
			set
			{
				SetValue( v =>  _causing = v, _causing, value,  "Causing", 14);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public CobieAsset @Affected 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _affected;
				((IPersistEntity)this).Activate(false);
				return _affected;
			} 
			set
			{
				SetValue( v =>  _affected = v, _affected, value,  "Affected", 15);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_issueType = (CobieIssueType)(value.EntityVal);
					return;
				case 8: 
					_risk = (CobieIssueRisk)(value.EntityVal);
					return;
				case 9: 
					_chance = (CobieIssueChance)(value.EntityVal);
					return;
				case 10: 
					_impact = (CobieIssueImpact)(value.EntityVal);
					return;
				case 11: 
					_owner = (CobieContact)(value.EntityVal);
					return;
				case 12: 
					_mitigation = value.StringVal;
					return;
				case 13: 
					_causing = (CobieAsset)(value.EntityVal);
					return;
				case 14: 
					_affected = (CobieAsset)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieIssue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieIssue
            var root = (@CobieIssue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieIssue left, @CobieIssue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieIssue left, @CobieIssue right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Created != null)
					yield return @Created;
				if (@ExternalSystem != null)
					yield return @ExternalSystem;
				if (@ExternalObject != null)
					yield return @ExternalObject;
				if (@IssueType != null)
					yield return @IssueType;
				if (@Risk != null)
					yield return @Risk;
				if (@Chance != null)
					yield return @Chance;
				if (@Impact != null)
					yield return @Impact;
				if (@Owner != null)
					yield return @Owner;
				if (@Causing != null)
					yield return @Causing;
				if (@Affected != null)
					yield return @Affected;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Causing != null)
					yield return @Causing;
				if (@Affected != null)
					yield return @Affected;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}