namespace cshapp.test {

	using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ProgramTest {
	[TestMethod]
	public void TestMethod1() {
		Assert.AreEqual(2, Program.f(1,1));
	}
}

}
