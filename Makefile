FILES=Program.cs Time.cs Length.cs

all: $(FILES)
	dotnet build

install: $(FILES)
	@if [ test -e /usr/local/bin/unitConverter ]; then \
		rm /usr/local/bin/unitConverter; \
	fi
	sudo dotnet publish -r linux-x64 -p:PublishSingleFile=true --sc /p:PublishSingleFile=true /p:PublishTrimmed=true
	cp ./bin/Release/net10.0/linux-x64/publish/unitConverter /usr/local/bin/unitConverter

# if statement doesnt work

uninstall:
	rm /usr/local/bin/unitConverter

clean:
	rm -r ./bin /usr/local/bin/unitConverter
