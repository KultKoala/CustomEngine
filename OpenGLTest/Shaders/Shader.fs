#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;
uniform bool EpsteinDead;

void main()
{
	// linearly interpolate between both textures (80% container, 20% awesomeface)
	if(EpsteinDead){
		FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 1.0f);
	} else {
		FragColor = texture(texture1,TexCoord);
	}
}