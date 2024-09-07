using AutoFixture;
using FluentAssertions;
using FoSouzaDev.Common.Domain.Exceptions;

namespace FoSouzaDev.Common.Domain.UnitaryTests.Exceptions;

public sealed class ValidateExceptionTest : BaseTest
{
    [Fact]
    public void Constructor_Success_CreateAnException()
    {
        // Arrange
        string expectedMessage = base.Fixture.Create<string>();

        // Act
        ValidateException ex = new(expectedMessage);

        // Assert
        ex.Message.Should().Be(expectedMessage);
    }
}