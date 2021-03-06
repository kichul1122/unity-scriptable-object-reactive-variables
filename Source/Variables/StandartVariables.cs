﻿using UnityEngine;

namespace WolarGames.Variables
{
    // Concrete implementations to be able to create concrete scriptable objects

    [CreateAssetMenu(menuName = "Variables/Bool")]
    public class BoolVariable : Variable<bool>
    { }

    [CreateAssetMenu(menuName = "Variables/Float")]
    public class FloatVariable : Variable<float>
    { }

    [CreateAssetMenu(menuName = "Variables/Int")]
    public class IntVariable : Variable<int>
    { }

    [CreateAssetMenu(menuName = "Variables/String")]
    public class StringVariable : Variable<string>
    { }

    [CreateAssetMenu(menuName = "Variables/Vector3")]
    public class Vector3Variable : Variable<Vector3>
    { }

    [CreateAssetMenu(menuName = "Variables/Vector2")]
    public class Vector2Variable : Variable<Vector2>
    { }
}