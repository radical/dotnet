﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//Microsoft.NET.Build.Extensions.Tasks (net7.0) has nullables disabled
#pragma warning disable IDE0240 // Remove redundant nullable directive
#nullable disable
#pragma warning restore IDE0240 // Remove redundant nullable directive

using System.Globalization;

namespace Microsoft.NET.Build.Tasks
{
    /// <summary>
    /// Represents an error that is neither avoidable in all cases nor indicative of a bug in this library.
    /// It will be logged as a plain build error without the exception type or stack.
    /// </summary>
    internal class BuildErrorException : Exception
    {
        public BuildErrorException()
        {
        }

        public BuildErrorException(string message) : base(message)
        {
        }

        public BuildErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public BuildErrorException(string format, params string[] args)
            : this(string.Format(CultureInfo.CurrentCulture, format, args))
        {
        }
    }
}
