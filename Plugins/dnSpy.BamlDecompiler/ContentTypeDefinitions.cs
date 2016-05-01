﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using dnSpy.Contracts.TextEditor;

namespace dnSpy.BamlDecompiler {
	static class ContentTypeDefinitions {
#pragma warning disable CS0169
		[ExportContentTypeDefinition(ContentTypes.BAML_DNSPY)]
		[DisplayName("BAML - dnSpy")]
		[BaseContentType(ContentTypes.BAML)]
		static readonly ContentTypeDefinition BAMLDnSpyContentTypeDefinition;
#pragma warning restore CS0169
	}
}
