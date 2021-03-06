using System;
using System.Collections;
/// <summary>
///Epsilon
/// </summary>
public class SingleEpsilon
{
    public const float ExpectEpsilon = (float)1.4e-45;

    public static int Main()
    {
        SingleEpsilon SingleEpsilon = new SingleEpsilon();

        TestLibrary.TestFramework.BeginTestCase("SingleEpsilon");
        if (SingleEpsilon.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Compare to ExpectEpsilon.");
        try
        {
            float actualValue = Single.Epsilon;
            if (actualValue != ExpectEpsilon)
            {
                TestLibrary.TestFramework.LogError("001", "Epsilon has error.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

}
