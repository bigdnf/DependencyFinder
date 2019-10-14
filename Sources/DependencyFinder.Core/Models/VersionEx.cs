﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace DependencyFinder.Core.Models
{
    public class VersionEx : IComparable<VersionEx>
    {
        public Version Value { get; set; }
        public string Beta { get; set; }

        public override string ToString() => string.IsNullOrWhiteSpace(Beta) ? Value.ToString() : $"{Value}-{Beta}";

        public static bool operator <(VersionEx ver1, VersionEx ver2)
        {
            return Comparison(ver1, ver2) < 0;
        }

        public static bool operator >(VersionEx ver1, VersionEx ver2)
        {
            return Comparison(ver1, ver2) > 0;
        }

        public static bool operator ==(VersionEx ver1, VersionEx ver2)
        {
            return Comparison(ver1, ver2) == 0;
        }

        public static bool operator !=(VersionEx ver1, VersionEx ver2)
        {
            return Comparison(ver1, ver2) != 0;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is VersionEx)) return false;

            return this == (VersionEx)obj;
        }

        public static bool operator <=(VersionEx ver1, VersionEx ver2)
        {
            return Comparison(ver1, ver2) <= 0;
        }

        public static bool operator >=(VersionEx ver1, VersionEx ver2)
        {
            return Comparison(ver1, ver2) >= 0;
        }

        public static int Comparison(VersionEx ver1, VersionEx ver2)
        {
            if (ver1.Value < ver2.Value)

                return -1;
            else if (ver1.Value == ver2.Value)

                return 0;
            else if (ver1.Value > ver2.Value)

                return 1;

            return 0;
        }

        public static VersionEx FromString(string version)
        {
            var previewDelimeter = version.IndexOf("-");
            if (previewDelimeter > -1)
            {
                return new VersionEx() { Value = new Version(version[..previewDelimeter]), Beta = version[(previewDelimeter + 1)..^0] };
            }
            else
            {
                return new VersionEx() { Value = new Version(version) };
            }
        }

        public int CompareTo([AllowNull] VersionEx other) => Comparison(this, other);
    }
}