# unity-save-load-json

This is a snippet from a larger Unity project meant to showcase the Save/Load functionality.

Serializing Save Data to JSON, loading it from that file, and Delete operations from in-game

Save Data - Handler for all the data types that are saved

Player Save Data - Serializes Player Data such as position, rotation, current HP, and interactions they've had with NPCs and environment

Save Data Manager - Exists as a singleton manager which contains references to the methods that handle saving, loading, and deleting data

Save Game Tester - Debug script to hook into UI buttons

Save Load - Methods for saving data by writing to a JSON output; configurable to any database type, reading the JSON file's save data for loading, and deleting the file if delete is invoked.

Serializable Dictionary - Unity doesn't support Serializable dictionaries which this utility covers for the purposes of reading and writing dictionaries to the save file.

WIP - World Save Game Manager - Unused in project at the moment but meant to handle saving the character to a scene rather than starting them in a default scene.
