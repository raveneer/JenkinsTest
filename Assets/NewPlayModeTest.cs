using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewPlayModeTest {

	[UnityTest]
	public IEnumerator Test_1()
	{
	    yield return new WaitForSeconds(1);
	}

    [UnityTest]
    public IEnumerator Test_2()
    {
        yield return new WaitForSeconds(1);
    }

    [UnityTest]
    public IEnumerator Test_3()
    {
        yield return new WaitForSeconds(1);
       Assert.Fail();
    }
}
