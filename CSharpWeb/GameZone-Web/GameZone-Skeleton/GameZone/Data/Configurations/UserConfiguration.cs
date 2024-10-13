﻿using GameZone.Data.Seed;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameZone.Data.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
	{
		public void Configure(EntityTypeBuilder<IdentityUser> builder)
		{
			DbSeeder.SeedUsers();
			builder.HasData(new IdentityUser[]
			{
				DbSeeder.GuestUser
			});
		}
	}
}
