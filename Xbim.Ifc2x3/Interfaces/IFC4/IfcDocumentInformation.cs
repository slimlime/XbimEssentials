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
namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcDocumentInformation : IIfcDocumentInformation
	{
		Xbim.Ifc4.MeasureResource.IfcIdentifier IIfcDocumentInformation.Identification 
		{ 
			get
			{
				//TODO: Handle return of Identification for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel IIfcDocumentInformation.Name 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)Name);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.Description 
		{ 
			get
			{
				if (Description == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)Description);
			} 
		}
		Xbim.Ifc4.ExternalReferenceResource.IfcURIReference? IIfcDocumentInformation.Location 
		{ 
			get
			{
				//TODO: Handle return of Location for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.Purpose 
		{ 
			get
			{
				if (Purpose == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)Purpose);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.IntendedUse 
		{ 
			get
			{
				if (IntendedUse == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)IntendedUse);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.Scope 
		{ 
			get
			{
				if (Scope == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)Scope);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcDocumentInformation.Revision 
		{ 
			get
			{
				if (Revision == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)Revision);
			} 
		}
		Xbim.Ifc4.ActorResource.IfcActorSelect IIfcDocumentInformation.DocumentOwner 
		{ 
			get
			{
				if (DocumentOwner == null) return null;
				var ifcorganization = DocumentOwner as Xbim.Ifc2x3.ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = DocumentOwner as Xbim.Ifc2x3.ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = DocumentOwner as Xbim.Ifc2x3.ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
		}
		IEnumerable<Xbim.Ifc4.ActorResource.IfcActorSelect> IIfcDocumentInformation.Editors 
		{ 
			get
			{
			foreach (var member in Editors)
			{
				var ifcorganization = member as Xbim.Ifc2x3.ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					yield return ifcorganization;
				var ifcperson = member as Xbim.Ifc2x3.ActorResource.IfcPerson;
				if (ifcperson != null) 
					yield return ifcperson;
				var ifcpersonandorganization = member as Xbim.Ifc2x3.ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					yield return ifcpersonandorganization;
			}
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDateTime? IIfcDocumentInformation.CreationTime 
		{ 
			get
			{
				//TODO: Handle return of CreationTime for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDateTime? IIfcDocumentInformation.LastRevisionTime 
		{ 
			get
			{
				//TODO: Handle return of LastRevisionTime for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcIdentifier? IIfcDocumentInformation.ElectronicFormat 
		{ 
			get
			{
				//TODO: Handle return of ElectronicFormat for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDate? IIfcDocumentInformation.ValidFrom 
		{ 
			get
			{
				//TODO: Handle return of ValidFrom for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDate? IIfcDocumentInformation.ValidUntil 
		{ 
			get
			{
				//TODO: Handle return of ValidUntil for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.ExternalReferenceResource.IfcDocumentConfidentialityEnum? IIfcDocumentInformation.Confidentiality 
		{ 
			get
			{
				switch (Confidentiality)
				{
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentConfidentialityEnum.PUBLIC:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentConfidentialityEnum.PUBLIC;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentConfidentialityEnum.RESTRICTED:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentConfidentialityEnum.RESTRICTED;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentConfidentialityEnum.CONFIDENTIAL:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentConfidentialityEnum.CONFIDENTIAL;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentConfidentialityEnum.PERSONAL:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentConfidentialityEnum.PERSONAL;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentConfidentialityEnum.USERDEFINED:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentConfidentialityEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentConfidentialityEnum.NOTDEFINED:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentConfidentialityEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.ExternalReferenceResource.IfcDocumentStatusEnum? IIfcDocumentInformation.Status 
		{ 
			get
			{
				switch (Status)
				{
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentStatusEnum.DRAFT:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentStatusEnum.DRAFT;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentStatusEnum.FINALDRAFT:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentStatusEnum.FINALDRAFT;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentStatusEnum.FINAL:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentStatusEnum.FINAL;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentStatusEnum.REVISION:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentStatusEnum.REVISION;
					
					case Xbim.Ifc2x3.ExternalReferenceResource.IfcDocumentStatusEnum.NOTDEFINED:
						return Xbim.Ifc4.ExternalReferenceResource.IfcDocumentStatusEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		IEnumerable<IIfcRelAssociatesDocument> IIfcDocumentInformation.DocumentInfoForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesDocument>(e => (e.RelatingDocument as IfcDocumentInformation) == this);
			} 
		}
		IEnumerable<IIfcDocumentReference> IIfcDocumentInformation.HasDocumentReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcDocumentReference>(e => (e.ReferencedDocument as IfcDocumentInformation) == this);
			} 
		}
		IEnumerable<IIfcDocumentInformationRelationship> IIfcDocumentInformation.IsPointedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcDocumentInformationRelationship>(e => e.RelatedDocuments != null &&  e.RelatedDocuments.Contains(this));
			} 
		}
		IEnumerable<IIfcDocumentInformationRelationship> IIfcDocumentInformation.IsPointer 
		{ 
			get
			{
				return Model.Instances.Where<IIfcDocumentInformationRelationship>(e => (e.RelatingDocument as IfcDocumentInformation) == this);
			} 
		}
	}
}