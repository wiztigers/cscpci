namespace cshapp.test {

	using NUnit.Framework;

[TestFixture]
public class ProgramTest {
	[Test]
	public void Test1() {
		Assert.AreEqual(2, Program.f(1,1));
	}
}

}
