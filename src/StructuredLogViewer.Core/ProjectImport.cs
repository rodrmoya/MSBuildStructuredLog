﻿using System;

namespace StructuredLogViewer
{
    public struct ProjectImport : IEquatable<ProjectImport>
    {
        public ProjectImport(string importedProject, int line, int column)
        {
            ProjectPath = importedProject;
            Line = line;
            Column = column;
        }

        public string ProjectPath { get; set; }

        /// <summary>
        /// 0-based
        /// </summary>
        public int Line { get; set; }
        public int Column { get; set; }

        public bool Equals(ProjectImport other)
        {
            return ProjectPath == other.ProjectPath
                && Line == other.Line
                && Column == other.Column;
        }

        public override bool Equals(object obj)
        {
            if (obj is ProjectImport other)
            {
                return Equals(other);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (ProjectPath, Line, Column).GetHashCode();
        }

        public override string ToString()
        {
            return $"{ProjectPath} ({Line},{Column})";
        }
    }
}
