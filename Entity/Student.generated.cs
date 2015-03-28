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
	
	// Table Name: Student
	public partial class Student: BASE_Entity
	{
		// Primary Keys
		public System.Guid StudentID { get; set; }
	
		// Non-Primary columns
		public System.Boolean Active { get; set; }
		public System.DateTime? DateOfBirth { get; set; }
		public System.String FirstName { get; set; }
		public System.String Gender { get; set; }
		public System.String Grade { get; set; }
		public System.String LastName { get; set; }
		public System.String MiddleName { get; set; }
		public System.String VisionDiagnosis { get; set; }
	
	}
	
	public class StudentMap: EntityTypeConfiguration<Student>
	{
		public StudentMap()
		{
			// Map entity to table
			ToTable("Student");
	
			// Map property to column
			Property(t => t.Active).HasColumnName("Active");
			Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
			Property(t => t.FirstName).HasColumnName("FirstName");
			Property(t => t.Gender).HasColumnName("Gender");
			Property(t => t.Grade).HasColumnName("Grade");
			Property(t => t.LastName).HasColumnName("LastName");
			Property(t => t.MiddleName).HasColumnName("MiddleName");
			Property(t => t.StudentID).HasColumnName("StudentID");
			Property(t => t.VisionDiagnosis).HasColumnName("VisionDiagnosis");
	
			// Primary Key
			HasKey(t => t.StudentID);
	
			// Additional property mappings
			Property(t => t.Active)
				.IsRequired();
	
			Property(t => t.Gender)
				.IsFixedLength()
				.HasMaxLength(1);
	
			Property(t => t.StudentID)
				.IsRequired();
	
	
		}
	}
	
	public static partial class StudentHelper
	{
		public static void AssignNewPK
			(this Student aStudent)
		{
			aStudent.StudentID = Guid.NewGuid().CombGuid();
		}
	
		/// <summary> 
		/// This code is fragile in that is ASSUMES that integer primary keys ARE
		/// AUTO-INCREMENTING columns whose value is governed by the database 
		/// server and that Guid primary keys are NOT "computed" values but rather 
		/// those whose column value is set by the client and/or server in a 
		/// fashion NOT governed by the database server.
		/// </summary>
		public static bool IsNew
			(this Student aStudent)
		{
			if (aStudent == null)
			{
				throw 
					new ArgumentNullException
						(
							"aStudent"
							, "Entity instance cannot be null!"
						);
			}
			bool vResult = 
				(aStudent.StudentID == Guid.Empty);
			return vResult;
		}
	
		public static void AssignTo
			(Student aFrom, Student aTo)
		{
			aTo.Active = aFrom.Active;
			aTo.DateOfBirth = aFrom.DateOfBirth;
			aTo.FirstName = aFrom.FirstName;
			aTo.Gender = aFrom.Gender;
			aTo.Grade = aFrom.Grade;
			aTo.LastName = aFrom.LastName;
			aTo.MiddleName = aFrom.MiddleName;
			aTo.StudentID = aFrom.StudentID;
			aTo.VisionDiagnosis = aFrom.VisionDiagnosis;
		}
	
		public static void AssignToNoPrimaryKeys
			(Student aFrom, Student aTo)
		{
			aTo.Active = aFrom.Active;
			aTo.DateOfBirth = aFrom.DateOfBirth;
			aTo.FirstName = aFrom.FirstName;
			aTo.Gender = aFrom.Gender;
			aTo.Grade = aFrom.Grade;
			aTo.LastName = aFrom.LastName;
			aTo.MiddleName = aFrom.MiddleName;
			aTo.VisionDiagnosis = aFrom.VisionDiagnosis;
		}
	
		public static void AssignToJustPrimaryKeys
			(Student aFrom, Student aTo)
		{
			aTo.StudentID = aFrom.StudentID;
		}
	
		public static void AssignFrom
			(this Student aTo, Student aFrom)
		{
			aTo.Active = aFrom.Active;
			aTo.DateOfBirth = aFrom.DateOfBirth;
			aTo.FirstName = aFrom.FirstName;
			aTo.Gender = aFrom.Gender;
			aTo.Grade = aFrom.Grade;
			aTo.LastName = aFrom.LastName;
			aTo.MiddleName = aFrom.MiddleName;
			aTo.StudentID = aFrom.StudentID;
			aTo.VisionDiagnosis = aFrom.VisionDiagnosis;
		}
	
		public static void AssignFromNoPrimaryKeys
			(this Student aTo, Student aFrom)
		{
			aTo.Active = aFrom.Active;
			aTo.DateOfBirth = aFrom.DateOfBirth;
			aTo.FirstName = aFrom.FirstName;
			aTo.Gender = aFrom.Gender;
			aTo.Grade = aFrom.Grade;
			aTo.LastName = aFrom.LastName;
			aTo.MiddleName = aFrom.MiddleName;
			aTo.VisionDiagnosis = aFrom.VisionDiagnosis;
		}
	
		public static void AssignFromJustPrimaryKeys
			(this Student aTo, Student aFrom)
		{
			aTo.StudentID = aFrom.StudentID;
		}
	
	}
}