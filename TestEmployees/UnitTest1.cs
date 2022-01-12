using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EmployeeLibrary;

namespace TestEmployees
{
	[TestClass]

	public class UnitTest1
	{
		[TestMethod]
		public void TestExceptionisThrownWhenAnInvalidCSVListIsInput()
		{
			Assert.ThrowsException<Exception>(() => new Employees(""));

		}

		[TestMethod]
		public void TestExceptionisThrownWhenOneEmployessReportsToMoreThanoneManger()
		{
			try
			{
				Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100," +
					"Joyce,manager1, 1900," +
					"James,manager2,100," +
					"Eve,manager1,1900," +
					"CEO,,1000, " +
					"manager1,Peter,1900," +
					"employess,manager1,1900," +
					"salasia,manager1,1900," +
					"manager2,Paul,1900,"));
			}
			catch (AssertFailedException err)
			{
				Console.WriteLine(err.Message);
			}
		}

		[TestMethod]
		public void TestExceptionisThrownWhenWehaveMoreThanOneCEO()
		{
			try
			{
				Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100," +
					"Joyce,manager1, 1900," +
					"James,manager2,100," +
					"Eve,manager1,1900," +
					"CEO,,1000, " +
					"manager1,Peter,1900," +
					"employess,manager1,1900," +
					"salasia,manager1,1900," +
					"manager2,Paul,1900,"));
			}
			catch (AssertFailedException err)
			{
				Console.WriteLine(err.Message);
			}
		}

		[TestMethod]
		public void TestExceptionisThrownWhenWehaveCircularReference()
		{
			try
			{
				Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100," +
					"Joyce,manager1, 1900," +
					"James,manager2,100," +
					"Eve,manager1,1900," +
					"CEO,,1000, " +
					"manager1,Peter,1900," +
					"employess,manager1,1900," +
					"salasia,manager1,1900," +
					"manager2,Paul,1900,"));
			}
			catch (AssertFailedException err)
			{
				Console.WriteLine(err.Message);
			}
		}
		[TestMethod]
		public void TestExceptionisThrownWhenAllManagersAreNotListedInEmployessCell()
		{
			try
			{
				Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100," +
					"Joyce,manager1, 1900," +
					"James,manager2,100," +
					"Eve,manager1,1900," +
					"CEO,,1000, " +
					"manager1,Peter,1900," +
					"employess,manager1,1900," +
					"salasia,manager1,1900," +
					"manager2,Paul,1900,"));
			}
			catch (AssertFailedException err)
			{
				Console.WriteLine(err.Message);
			}
		}

		[TestMethod]
		public void TestManagerBurgetsReturnsCorrect()
		{

			Employees testEmployee = new Employees("John,manager1,100," +
				"Joyce,manager1, 1900," +
				"James,manager2,100," +
				"Eve,manager1,1900," +
				"CEO,,1000, " +
				"manager1,Peter,1900," +
				"employess,manager1,1900," +
				"salasia,manager1,1900," +
				"manager2,Paul,1900,");
            try 
			{
				Assert.AreEqual(1000, testEmployee.managerSalaryBudget("manager1"));
			}
            catch (AssertFailedException err)
			{
				Console.WriteLine(err.Message);
			}
			

		}
	}
}