﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Windows.Forms;

/// <summary>
///  Specifies the position of the image on the control.
/// </summary>
public enum ImageLayout
{
    /// <summary>
    ///  The image is aligned TOP - LEFT across the controls client rectangle.
    /// </summary>
    None,

    /// <summary>
    ///  The image is tiled across the controls client rectangle.
    /// </summary>
    Tile,

    /// <summary>
    ///  The image is centered within the controls client rectangle.
    /// </summary>
    Center,

    /// <summary>
    ///  The image is stretched across the controls client rectangle.
    /// </summary>
    Stretch,

    /// <summary>
    ///  The image is stretched across the controls client rectangle.
    /// </summary>
    Zoom,
}
