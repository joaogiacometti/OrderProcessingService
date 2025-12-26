# Makefile for EF Core migrations

# Projects
STARTUP=Presentation
DB=Infrastructure

# Migration name argument
MIGRATION_NAME?=NewMigration

# Default target
.PHONY: help
help:
	@echo "Usage:"
	@echo "  make add   MIGRATION_NAME=MyMigration   # Add a migration"
	@echo "  make update                            # Update database"
	@echo "  make remove                             # Remove last migration"

# Add a migration
.PHONY: add
add:
	dotnet ef migrations add $(MIGRATION_NAME) -p $(DB) -s $(STARTUP)

# Apply migrations to database
.PHONY: update
update:
	dotnet ef database update -p $(DB) -s $(STARTUP)

# Remove last migration
.PHONY: remove
remove:
	dotnet ef migrations remove -p $(DB) -s $(STARTUP)
