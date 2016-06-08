// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <code>ImageMaterial</code> to a <see cref="CesiumOutputStream" />.  A <code>ImageMaterial</code> is a material that fills the surface with an image.
    /// </summary>
    public class ImageMaterialCesiumWriter : CesiumPropertyWriter<ImageMaterialCesiumWriter>
    {
        /// <summary>
        /// The name of the <code>image</code> property.
        /// </summary>
        public const string ImagePropertyName = "image";

        /// <summary>
        /// The name of the <code>color</code> property.
        /// </summary>
        public const string ColorPropertyName = "color";

        /// <summary>
        /// The name of the <code>transparent</code> property.
        /// </summary>
        public const string TransparentPropertyName = "transparent";

        /// <summary>
        /// The name of the <code>repeat</code> property.
        /// </summary>
        public const string RepeatPropertyName = "repeat";

        private readonly Lazy<UriCesiumWriter> m_image = new Lazy<UriCesiumWriter>(() => new UriCesiumWriter(ImagePropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_color = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(ColorPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_transparent = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(TransparentPropertyName), false);
        private readonly Lazy<RepeatCesiumWriter> m_repeat = new Lazy<RepeatCesiumWriter>(() => new RepeatCesiumWriter(RepeatPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public ImageMaterialCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ImageMaterialCesiumWriter(ImageMaterialCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override ImageMaterialCesiumWriter Clone()
        {
            return new ImageMaterialCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <code>image</code> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <code>image</code> property defines the image to display on the surface.
        /// </summary>
        public UriCesiumWriter ImageWriter
        {
            get { return m_image.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <code>image</code> property.  The <code>image</code> property defines the image to display on the surface.
        /// </summary>
        public UriCesiumWriter OpenImageProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ImageWriter);
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>uri</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="resource">A resource object describing external data.</param>
        public void WriteImageProperty(CesiumResource resource)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(resource);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>uri</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteImageProperty(Uri uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>uri</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteImageProperty(string uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>uri</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data.  The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteImageProperty(Uri uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>uri</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="uri">The URI of the data.  The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteImageProperty(string uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>uri</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="image">The image.  A data URI will be created for this image, using PNG encoding.</param>
        public void WriteImageProperty(Image image)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(image);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>uri</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="image">The image.  A data URI will be created for this image.</param>
        /// <param name="imageFormat">The image format to use to encode the image in the data URI.</param>
        public void WriteImageProperty(Image image, CesiumImageFormat imageFormat)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(image, imageFormat);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>reference</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteImagePropertyReference(Reference value)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>reference</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteImagePropertyReference(string value)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>reference</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteImagePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <code>image</code> property as a <code>reference</code> value.  The <code>image</code> property specifies the image to display on the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteImagePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <code>color</code> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <code>color</code> property defines the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        public ColorCesiumWriter ColorWriter
        {
            get { return m_color.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <code>color</code> property.  The <code>color</code> property defines the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        public ColorCesiumWriter OpenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorWriter);
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>rgba</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorProperty(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>rgba</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>rgba</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `colors` collection.</param>
        /// <param name="length">The number of elements to use from the `colors` collection.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>rgbaf</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>reference</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(Reference value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>reference</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorPropertyReference(string value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>reference</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <code>color</code> property as a <code>reference</code> value.  The <code>color</code> property specifies the color of the image. This color value is multiplied with the image to produce the final color.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <code>transparent</code> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <code>transparent</code> property defines whether or not the image has transparency.
        /// </summary>
        public BooleanCesiumWriter TransparentWriter
        {
            get { return m_transparent.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <code>transparent</code> property.  The <code>transparent</code> property defines whether or not the image has transparency.
        /// </summary>
        public BooleanCesiumWriter OpenTransparentProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(TransparentWriter);
        }

        /// <summary>
        /// Writes a value for the <code>transparent</code> property as a <code>boolean</code> value.  The <code>transparent</code> property specifies whether or not the image has transparency.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteTransparentProperty(bool value)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>transparent</code> property as a <code>reference</code> value.  The <code>transparent</code> property specifies whether or not the image has transparency.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteTransparentPropertyReference(Reference value)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>transparent</code> property as a <code>reference</code> value.  The <code>transparent</code> property specifies whether or not the image has transparency.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteTransparentPropertyReference(string value)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>transparent</code> property as a <code>reference</code> value.  The <code>transparent</code> property specifies whether or not the image has transparency.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteTransparentPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <code>transparent</code> property as a <code>reference</code> value.  The <code>transparent</code> property specifies whether or not the image has transparency.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteTransparentPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenTransparentProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <code>repeat</code> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <code>repeat</code> property defines the number of times the image repeats along each axis.
        /// </summary>
        public RepeatCesiumWriter RepeatWriter
        {
            get { return m_repeat.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <code>repeat</code> property.  The <code>repeat</code> property defines the number of times the image repeats along each axis.
        /// </summary>
        public RepeatCesiumWriter OpenRepeatProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RepeatWriter);
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>cartesian2</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRepeatProperty(Rectangular value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>cartesian2</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WriteRepeatProperty(double x, double y)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(x, y);
            }
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>cartesian2</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="dates">The dates at which the vector is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRepeatProperty(IList<JulianDate> dates, IList<Rectangular> values)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>cartesian2</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="dates">The dates at which the vector is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteRepeatProperty(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>reference</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRepeatPropertyReference(Reference value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>reference</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteRepeatPropertyReference(string value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>reference</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRepeatPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <code>repeat</code> property as a <code>reference</code> value.  The <code>repeat</code> property specifies the number of times the image repeats along each axis.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRepeatPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
