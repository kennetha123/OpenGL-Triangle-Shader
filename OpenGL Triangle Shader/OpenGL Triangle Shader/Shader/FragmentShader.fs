#version 330 core
out vec4 FragColor;  
in vec3 ourColor;

in vec2 TextureCoord;

uniform sampler2D ourTexture;
uniform sampler2D ourTexture2;
void main()
{
    FragColor = mix(texture(ourTexture , TextureCoord), texture(ourTexture2, TextureCoord), 0.2f);
}