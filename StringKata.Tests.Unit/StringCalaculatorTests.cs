namespace StringKata.Tests.Unit
{
	using System;

	using FluentAssertions;

	using Xunit;

	public class StringCalaculatorTests
	{
		[Fact]
		public void WhenPassedEmptyStringShouldReturnZero()
		{
			// Arrange

			// Act
			int result = Add("");

			// Assert
			result.Should().Be(0);
		}

		[Fact]
		public void WhenPassedStringWithOneNumberShouldReturnSameNumber()
		{
			// Arrange

			// Act
			int result = Add("1");

			// Assert
			result.Should().Be(1);
		}

		[Fact]
		public void WhenPassedNullShouldReturnException()
		{
			// Arrange
			

			// Act
			Exception ex = Assert.Throws<ArgumentNullException>(() => Add(null));

			// Assert
			ex.Message.Should().Be("Calculation string should not be null");
		}

		private int Add(string numberString)
		{
			if (numberString == null)
			{
				throw new ArgumentNullException();
			}

			if (numberString == string.Empty)
			{
				return 0;
			}

			return int.Parse(numberString);
		}
	}

}