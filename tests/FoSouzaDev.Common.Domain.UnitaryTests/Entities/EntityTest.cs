using AutoFixture;
using FluentAssertions;
using FoSouzaDev.Common.Domain.Entities;

namespace FoSouzaDev.Common.Domain.UnitaryTests.Entities;

public sealed class EntityTest : BaseTest
{
    private class DummyEntity(Guid id, DateTimeOffset creationDateTime)
        : Entity(id, creationDateTime)
    {
    }

    [Fact]
    public void Constructor_Success_CreateAnEntity()
    {
        // Arrange
        Guid expectedId = Guid.NewGuid();
        DateTimeOffset expectedCreationDateTime = base.Fixture.Create<DateTimeOffset>();

        // Act
        DummyEntity entity = new(expectedId, expectedCreationDateTime);

        // Assert
        entity.Id.Should().Be(expectedId);
        entity.CreationDateTime.Should().Be(expectedCreationDateTime);
    }
}