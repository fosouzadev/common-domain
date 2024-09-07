using FluentAssertions;
using FoSouzaDev.Common.Domain.Exceptions;

namespace FoSouzaDev.Common.Domain.UnitaryTests.Exceptions;

public sealed class NotFoundExceptionTest : BaseTest
{
    [Fact]
    public void Constructor_Success_CreateAnException()
    {
        // Arrange
        Guid expectedId = Guid.NewGuid();

        // Act
        NotFoundException ex = new(expectedId);

        // Assert
        ex.Message.Should().Be("Not found.");
        ex.Id.Should().Be(expectedId);
    }
}