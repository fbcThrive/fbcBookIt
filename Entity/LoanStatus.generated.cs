//-----------------------------------------------------------------------------
// <auto-generated> 
// ^^^ Comment out the above line to allow ReSharper to validate the 
//  using clauses.
//	This code was generated from a template.
//
//	Manual changes to this file may cause unexpected behavior in your 
//	application.
//	Manual changes to this file will be overwritten if the code is 
//	regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------

namespace FbcBookIt.Entity
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.Entity.ModelConfiguration;
	using System.ComponentModel.DataAnnotations.Schema;
	//using AWEFramework.AWEExtensions;
	using FbcBookIt.Utility;
	using System.Collections.Generic;
	
	// Table Name: LoanStatus
	public partial class LoanStatus: BASE_Entity
	{
		// Primary Keys
		public System.Int32 LoanStatusId { get; set; }
	
		// Non-Primary columns
		public System.Boolean Active { get; set; }
		public System.String StatusDescription { get; set; }
	
	}
	
	public class LoanStatusMap: EntityTypeConfiguration<LoanStatus>
	{
		public LoanStatusMap()
		{
			// Map entity to table
			ToTable("LoanStatus");
	
			// Map property to column
			Property(t => t.Active).HasColumnName("Active");
			Property(t => t.LoanStatusId).HasColumnName("LoanStatusId");
			Property(t => t.StatusDescription).HasColumnName("StatusDescription");
	
			// Primary Key
			HasKey(t => t.LoanStatusId);
	
			// Additional property mappings
			Property(t => t.Active)
				.IsRequired();
	
			Property(t => t.LoanStatusId)
				.IsRequired();
	
	
		}
	}
	
	public static partial class LoanStatusHelper
	{
		public static void AssignNewPK
			(this LoanStatus aLoanStatus)
		{
		}
	
		/// <summary> 
		/// This code is fragile in that is ASSUMES that integer primary keys ARE
		/// AUTO-INCREMENTING columns whose value is governed by the database 
		/// server and that Guid primary keys are NOT "computed" values but rather 
		/// those whose column value is set by the client and/or server in a 
		/// fashion NOT governed by the database server.
		/// </summary>
		public static bool IsNew
			(this LoanStatus aLoanStatus)
		{
			if (aLoanStatus == null)
			{
				throw 
					new ArgumentNullException
						(
							"aLoanStatus"
							, "Entity instance cannot be null!"
						);
			}
			bool vResult = 
				(aLoanStatus.LoanStatusId < 1);
			return vResult;
		}
	
		public static void AssignTo
			(LoanStatus aFrom, LoanStatus aTo)
		{
			aTo.Active = aFrom.Active;
			aTo.LoanStatusId = aFrom.LoanStatusId;
			aTo.StatusDescription = aFrom.StatusDescription;
		}
	
		public static void AssignToNoPrimaryKeys
			(LoanStatus aFrom, LoanStatus aTo)
		{
			aTo.Active = aFrom.Active;
			aTo.StatusDescription = aFrom.StatusDescription;
		}
	
		public static void AssignToJustPrimaryKeys
			(LoanStatus aFrom, LoanStatus aTo)
		{
			aTo.LoanStatusId = aFrom.LoanStatusId;
		}
	
		public static void AssignFrom
			(this LoanStatus aTo, LoanStatus aFrom)
		{
			aTo.Active = aFrom.Active;
			aTo.LoanStatusId = aFrom.LoanStatusId;
			aTo.StatusDescription = aFrom.StatusDescription;
		}
	
		public static void AssignFromNoPrimaryKeys
			(this LoanStatus aTo, LoanStatus aFrom)
		{
			aTo.Active = aFrom.Active;
			aTo.StatusDescription = aFrom.StatusDescription;
		}
	
		public static void AssignFromJustPrimaryKeys
			(this LoanStatus aTo, LoanStatus aFrom)
		{
			aTo.LoanStatusId = aFrom.LoanStatusId;
		}
	
	}
}
