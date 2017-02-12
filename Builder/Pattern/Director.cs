using System;

namespace Builder
{
    /// <summary>
    /// ��������� ����������� ��������� (Builder), �������� ���� ��������� �������� ��������� �������.
    /// </summary>
    class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
