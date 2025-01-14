﻿using System;

namespace Zhongli.Services.CommandHelp;

/// <summary>
///     Hides the module or command from display
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class HiddenFromHelpAttribute : Attribute { }