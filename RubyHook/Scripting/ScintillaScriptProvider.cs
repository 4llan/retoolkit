﻿// Retoolkit - Scripting-based reverse engineering toolkit for Windows OS'es
// Copyright (C) 2010  James Leskovar
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScintillaNet;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using System.IO;

namespace Retoolkit.Scripting
{
  class ScintillaScriptProvider : TextContentProvider
  {
    private Scintilla m_editor;
    private Encoding m_enc;

    public ScintillaScriptProvider(Scintilla scintilla, Encoding encoding)
    {
      m_editor = scintilla;
      m_enc = encoding;
    }

    public override SourceCodeReader GetReader()
    {
      return new SourceCodeReader(new StringReader(m_editor.Text), m_enc);
    }
  }
}
