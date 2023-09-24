# Godot GPU particles issue

This project demonstrates GPU particles rendering issue: [https://github.com/godotengine/godot/issues/82185)(https://github.com/godotengine/godot/issues/82185)


IMPORTANT:
- Issue happens only if exported to a binary (Macbook M1 Pro). No issue when running from editor.
- There is a disabled MultiMeshFlock - the problem disappears if you remove it.
- There is gradient-based coloring of the particles in Process Material - if you disable it - the problem dissapears.
