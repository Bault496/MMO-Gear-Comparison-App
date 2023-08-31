USE [MMOGearComparsionApp]
GO
SET IDENTITY_INSERT [dbo].[Gears] ON 
GO
INSERT [dbo].[Gears] ([ItemId], [ItemName], [ItemLevel], [DamageScaling],
	 				  [ArmorScaling], [PrimaryStat], [PrimaryStatScaling], [SecondaryStat],
                      [SecondaryStatScaling], [Durability], [GearSlot], [GearType]) 
	VALUES (1, 'Bronze Chestplate', 10, 0,
		10, 'Strength', 5, 'Tenacity',
		5, 80, 'Chest', 'Armor')
GO
INSERT [dbo].[Gears] ([ItemId], [ItemName], [ItemLevel], [DamageScaling],
	 				  [ArmorScaling], [PrimaryStat], [PrimaryStatScaling], [SecondaryStat],
                      [SecondaryStatScaling], [Durability], [GearSlot], [GearType]) 
	VALUES (2, 'Iron Chestplate', 15, 0,
		13, 'Strength', 5, 'Tenacity',
		7, 80, 'Chest', 'Armor')
GO
INSERT [dbo].[Gears] ([ItemId], [ItemName], [ItemLevel], [DamageScaling],
	 				  [ArmorScaling], [PrimaryStat], [PrimaryStatScaling], [SecondaryStat],
                      [SecondaryStatScaling], [Durability], [GearSlot], [GearType]) 
	VALUES (3, 'Bronze Sword', 10, 10,
		0, 'Strength', 5, 'Critical Chance',
		5, 80, 'Main Hand', 'Weapon')
GO
INSERT [dbo].[Gears] ([ItemId], [ItemName], [ItemLevel], [DamageScaling],
	 				  [ArmorScaling], [PrimaryStat], [PrimaryStatScaling], [SecondaryStat],
                      [SecondaryStatScaling], [Durability], [GearSlot], [GearType]) 
	VALUES (4, 'Iron Sword', 10, 15,
		0, 'Strength', 5, 'Haste',
		5, 80, 'Main Hand', 'Weapon')
GO
SET IDENTITY_INSERT [dbo].[Gears] OFF