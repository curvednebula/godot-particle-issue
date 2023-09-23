shader_type particles;
render_mode disable_velocity;
render_mode keep_data;

uniform vec3 verts[4];

float rand_from_seed(in uint seed) {
  int k;
  int s = int(seed);
  if (s == 0)
    s = 305420679;
  k = s / 127773;
  s = 16807 * (s - k * 127773) - 2836 * k;
  if (s < 0)
    s += 2147483647;
  seed = uint(s);
  return float(seed % uint(65536)) / 65535.0;
}

uint hash(uint x) {
  x = ((x >> uint(16)) ^ x) * uint(73244475);
  x = ((x >> uint(16)) ^ x) * uint(73244475);
  x = (x >> uint(16)) ^ x;
  return x;
}

void scale(inout mat4 transform, in float scale) {
  transform[0].x = scale;
  transform[1].y = scale;
  transform[2].z = scale;
}

void start() {
  uint seed = hash(NUMBER + uint(1) + RANDOM_SEED);

  VELOCITY = vec3(
    rand_from_seed(seed) * 2.0 - 1.0,
    rand_from_seed(seed) * 2.0 - 1.0,
    rand_from_seed(seed) * 2.0 - 1.0
  );
  // TRANSFORM[3].xyz = verts[INDEX];
  CUSTOM.x = 0.0;
  scale(TRANSFORM, 0.5);
  COLOR = vec4(1, 1, 1, 1);
}

void process() {
  CUSTOM.x += DELTA;
  float lifetime = CUSTOM.x / LIFETIME;

  // COLOR = vec4(lifetime, 0, 0, 1);

  vec3 delta = verts[INDEX] - TRANSFORM[3].xyz;
  VELOCITY += delta * DELTA * 100.0 + ATTRACTOR_FORCE;
  VELOCITY *= 0.9;
  TRANSFORM[3].xyz += VELOCITY * DELTA;
}
