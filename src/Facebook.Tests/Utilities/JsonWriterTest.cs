// <copyright file="JsonWriterTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections;
using System.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook.Utilities
{
    /// <summary>This class contains parameterized unit tests for JsonWriter</summary>
    [PexClass(typeof(JsonWriter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class JsonWriterTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal JsonWriter Constructor()
        {
            JsonWriter target = new JsonWriter();
            return target;
            // TODO: add assertions to method JsonWriterTest.Constructor()
        }

        /// <summary>Test stub for .ctor(Boolean)</summary>
        [PexMethod]
        internal JsonWriter Constructor01(bool minimizeWhitespace)
        {
            JsonWriter target = new JsonWriter(minimizeWhitespace);
            return target;
            // TODO: add assertions to method JsonWriterTest.Constructor01(Boolean)
        }

        /// <summary>Test stub for .ctor(TextWriter)</summary>
        [PexMethod]
        internal JsonWriter Constructor02(TextWriter writer)
        {
            JsonWriter target = new JsonWriter(writer);
            return target;
            // TODO: add assertions to method JsonWriterTest.Constructor02(TextWriter)
        }

        /// <summary>Test stub for .ctor(TextWriter, Boolean)</summary>
        [PexMethod]
        internal JsonWriter Constructor03(TextWriter writer, bool minimizeWhitespace)
        {
            JsonWriter target = new JsonWriter(writer, minimizeWhitespace);
            return target;
            // TODO: add assertions to method JsonWriterTest.Constructor03(TextWriter, Boolean)
        }

        /// <summary>Test stub for EndScope()</summary>
        [PexMethod]
        internal void EndScope([PexAssumeUnderTest]JsonWriter target)
        {
            target.EndScope();
            // TODO: add assertions to method JsonWriterTest.EndScope(JsonWriter)
        }

        /// <summary>Test stub for Json</summary>
        [PexMethod]
        internal void JsonGet([PexAssumeUnderTest]JsonWriter target)
        {
            string result = target.Json;
            // TODO: add assertions to method JsonWriterTest.JsonGet(JsonWriter)
        }

        /// <summary>Test stub for StartArrayScope()</summary>
        [PexMethod]
        internal void StartArrayScope([PexAssumeUnderTest]JsonWriter target)
        {
            target.StartArrayScope();
            // TODO: add assertions to method JsonWriterTest.StartArrayScope(JsonWriter)
        }

        /// <summary>Test stub for StartObjectScope()</summary>
        [PexMethod]
        internal void StartObjectScope([PexAssumeUnderTest]JsonWriter target)
        {
            target.StartObjectScope();
            // TODO: add assertions to method JsonWriterTest.StartObjectScope(JsonWriter)
        }

        /// <summary>Test stub for WriteName(String)</summary>
        [PexMethod]
        internal void WriteName([PexAssumeUnderTest]JsonWriter target, string name)
        {
            target.WriteName(name);
            // TODO: add assertions to method JsonWriterTest.WriteName(JsonWriter, String)
        }

        /// <summary>Test stub for WriteValue(Boolean)</summary>
        [PexMethod]
        internal void WriteValue([PexAssumeUnderTest]JsonWriter target, bool value)
        {
            target.WriteValue(value);
            // TODO: add assertions to method JsonWriterTest.WriteValue(JsonWriter, Boolean)
        }

        /// <summary>Test stub for WriteValue(Int32)</summary>
        [PexMethod]
        internal void WriteValue01([PexAssumeUnderTest]JsonWriter target, int value)
        {
            target.WriteValue(value);
            // TODO: add assertions to method JsonWriterTest.WriteValue01(JsonWriter, Int32)
        }

        /// <summary>Test stub for WriteValue(Single)</summary>
        [PexMethod]
        internal void WriteValue02([PexAssumeUnderTest]JsonWriter target, float value)
        {
            target.WriteValue(value);
            // TODO: add assertions to method JsonWriterTest.WriteValue02(JsonWriter, Single)
        }

        /// <summary>Test stub for WriteValue(Double)</summary>
        [PexMethod]
        internal void WriteValue03([PexAssumeUnderTest]JsonWriter target, double value)
        {
            target.WriteValue(value);
            // TODO: add assertions to method JsonWriterTest.WriteValue03(JsonWriter, Double)
        }

        /// <summary>Test stub for WriteValue(DateTime)</summary>
        [PexMethod]
        internal void WriteValue04([PexAssumeUnderTest]JsonWriter target, DateTime dateTime)
        {
            target.WriteValue(dateTime);
            // TODO: add assertions to method JsonWriterTest.WriteValue04(JsonWriter, DateTime)
        }

        /// <summary>Test stub for WriteValue(String)</summary>
        [PexMethod]
        internal void WriteValue05([PexAssumeUnderTest]JsonWriter target, string s)
        {
            target.WriteValue(s);
            // TODO: add assertions to method JsonWriterTest.WriteValue05(JsonWriter, String)
        }

        /// <summary>Test stub for WriteValue(ICollection)</summary>
        [PexMethod]
        internal void WriteValue06([PexAssumeUnderTest]JsonWriter target, ICollection items)
        {
            target.WriteValue(items);
            // TODO: add assertions to method JsonWriterTest.WriteValue06(JsonWriter, ICollection)
        }

        /// <summary>Test stub for WriteValue(IDictionary)</summary>
        [PexMethod]
        internal void WriteValue07([PexAssumeUnderTest]JsonWriter target, IDictionary record)
        {
            target.WriteValue(record);
            // TODO: add assertions to method JsonWriterTest.WriteValue07(JsonWriter, IDictionary)
        }

        /// <summary>Test stub for WriteValue(Object)</summary>
        [PexMethod]
        internal void WriteValue08([PexAssumeUnderTest]JsonWriter target, object o)
        {
            target.WriteValue(o);
            // TODO: add assertions to method JsonWriterTest.WriteValue08(JsonWriter, Object)
        }
    }
}
