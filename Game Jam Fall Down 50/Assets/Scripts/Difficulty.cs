using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty  {

    static float secondsToMaxDifficulty = 60;

    public static float GetDifficultyPercent()
    {
        return Time.time / secondsToMaxDifficulty;
    }
}
