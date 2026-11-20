# PolyScriptTemplate

A template for a [PolyMod](https://github.com/PolyModdingTeam/PolyMod) script mod.

## Layout

- `Main.cs` – the mod's code. PolyMod calls the static `Load(ManualLogSource)` method when it loads the mod.
- `Mod/` – everything else that goes in the mod: `manifest.json`, sprites, language files and so on.
  Set the `id`, `name`, `version` and `authors` in `Mod/manifest.json`. The `id` can only have lowercase letters and underscores, and the `version` must be plain numbers such as `1.0.0` (no `-pre` suffix).

## Building and testing in the game

Copy `local.props.example` to `local.props` (git ignores it) and set:

| Setting | What it does |
| --- | --- |
| `ModsDir` | The game's `Mods` folder. After each build, the `.dll` and the contents of `Mod/` are copied to `<ModsDir>/<ModName>`; the old copy there is deleted first. Empty: no copy. |
| `LaunchGame` | `steam` or `epic` starts the game after the copy. Empty: no start. |
| `ModName` | Name of the mod's folder in `ModsDir`. Empty: the project name. |

Then run `dotnet build` (or build in your IDE). Without `local.props`, the build only compiles.

Close the game before you build: a running game does not reload the mod.

## Releases

GitHub Actions builds every push and pull request and uploads the `.polymod` file as an artifact.
Run the workflow by hand (Actions → CI/CD → Run workflow) to make a GitHub release named after the `version` in `Mod/manifest.json`.
