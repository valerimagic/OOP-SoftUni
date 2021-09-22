using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    public void Test1()
    {
        Axe axe = new Axe(2, 2);
        Dummy dumy = new Dummy(5, 5);
        axe.Attack(dumy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(1));


    }
}