using FluentAssertions;
using FoSouzaDev.Common.Domain.Exceptions;

namespace FoSouzaDev.Common.Domain.UnitaryTests.Exceptions;

public sealed class ConflictExceptionTest : BaseTest
{
    [Fact]
    public void Constructor_Success_CreateAnException()
    {
        // Arrange
        Guid expectedId = Guid.NewGuid();

        // Act
        ConflictException ex = new(expectedId);

        // Assert
        ex.Message.Should().Be("Already registered.");
        ex.Id.Should().Be(expectedId);
    }
}