﻿using Microsoft.Xna.Framework.Content.Pipeline;
using MonoGame.Extended.Content.Pipeline.Tiled;
using NSubstitute;
using NUnit.Framework;

namespace MonoGame.Extended.Content.Pipeline.Tests
{
    [TestFixture]
    public class TiledMapImporterTests
    {
        [Test]
        public void TiledMapImporter_Import_Test()
        {
            const string filename = @"TestData\level01.tmx";
            var importer = new TiledMapImporter();
            var map = importer.Import(filename, Substitute.For<ContentImporterContext>());

            Assert.IsNotNull(map);
            //Assert.AreEqual("Tile Layer 2", map.Layers[0].Name);
        }
    }
}