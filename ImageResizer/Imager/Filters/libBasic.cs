﻿#region (c)2010 Hawkynt
/*
 *  cImage 
 *  Image filtering library 
    Copyright (C) 2010 Hawkynt

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * This is a C# port of my former classImage perl library.
 * You can use and modify my code as long as you give me a credit and 
 * inform me about updates, changes new features and modification. 
 * Distribution and selling is allowed. Would be nice if you give some 
 * payback.
 * 
 * Mapping usually is implemented as
 *
 * 2x:
 * C0 C1 C2     00  01
 * C3 C4 C5 =>
 * C6 C7 C8     10  11
 * 
 * 3x:
 * C0 C1 C2    00 01 02
 * C3 C4 C5 => 10 11 12
 * C6 C7 C8    20 21 22
      
 */
#endregion
using nImager;

namespace nImager.Filters {
  static class libBasic{
    public static void voidHScanlines(cImage objSrc, int intSrcX, int intSrcY, cImage objTgt, int intTgtX, int intTgtY, byte byteScaleX, byte byteScaleY, object objParam) {
      sPixel stPixel = objSrc[intSrcX, intSrcY];
      objTgt[intTgtX, intTgtY] = stPixel;
      float fltFactor = (float)objParam / 100f + 1f;
      objTgt[intTgtX, intTgtY + 1] = stPixel * fltFactor;
    }
    public static void voidVScanlines(cImage objSrc, int intSrcX, int intSrcY, cImage objTgt, int intTgtX, int intTgtY, byte byteScaleX, byte byteScaleY, object objParam) {
      sPixel stPixel = objSrc[intSrcX, intSrcY];
      objTgt[intTgtX, intTgtY] = stPixel;
      float fltFactor = (float)objParam / 100f + 1f;
      objTgt[intTgtX + 1, intTgtY] = stPixel * fltFactor;
    }
    
  }
}
