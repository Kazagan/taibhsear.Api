using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data;

public static class ColumnTypes
{
    public static PropertyBuilder VarcharWithMaxLength(this PropertyBuilder builder, int maxLength) => builder
        .HasColumnType("VARCHAR")
        .HasMaxLength(maxLength);
}