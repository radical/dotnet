#if XUNIT_NULLABLE
#nullable enable
#endif

using System;

namespace Xunit.Sdk
{
	/// <summary>
	/// Exception thrown when Assert.IsNotAssignableFrom fails.
	/// </summary>
#if XUNIT_VISIBILITY_INTERNAL
	internal
#else
	public
#endif
	partial class IsNotAssignableFromException : XunitException
	{
		IsNotAssignableFromException(string message) :
			base(message)
		{ }

		/// <summary>
		/// Creates a new instance of the <see cref="IsNotAssignableFromException"/> class to be thrown when
		/// the value is compatible with the given type.
		/// </summary>
		/// <param name="expected">The expected type</param>
		/// <param name="actual">The actual object value</param>
		public static IsNotAssignableFromException ForCompatibleType(
			Type expected,
			object actual) =>
				new IsNotAssignableFromException(
					"Assert.IsNotAssignableFrom() Failure: Value is a compatible type" + Environment.NewLine +
					"Expected: " + ArgumentFormatter.Format(Assert.GuardArgumentNotNull(nameof(expected), expected)) + Environment.NewLine +
					"Actual:   " + ArgumentFormatter.Format(Assert.GuardArgumentNotNull(nameof(actual), actual).GetType())
				);
	}
}
