using NUnit.Framework;
using UnityEngine;

public class NewTestScript
{
    [Test]
    public void Test()
    {

        var go = new GameObject("MyGaemeObject");
        Assert.AreEqual("MyGameObject",go.name);
    }


}
