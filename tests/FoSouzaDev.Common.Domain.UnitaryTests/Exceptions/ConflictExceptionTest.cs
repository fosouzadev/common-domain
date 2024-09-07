using AutoFixture;
using FluentAssertions;
using FoSouzaDev.Common.Domain.Exceptions;

namespace FoSouzaDev.Common.Domain.UnitaryTests.Exceptions;

public sealed class ConflictExceptionTest : BaseTest
{
    [Fact]
    public void Constructor_Success_CreateAnException()
    {
        // Arrange
        string expectedIdentifier = base.Fixture.Create<string>();

        // Act
        ConflictException ex = new(expectedIdentifier);

        // Assert
        ex.Message.Should().Be("Already registered.");
        ex.Identifier.Should().Be(expectedIdentifier);
    }
}