FROM mcr.microsoft.com/dotnet/aspnet:8.0
COPY bin/Release/net8.0/publish/ app/
WORKDIR /app
# Set environment variables. Replace "localhost.pfx" according to the certificate filename you have.
# Change values accordingly if you're using a different certificate file name.
ENV ASPNETCORE_URLS=https://+:443;http://+:80
ENV ASPNETCORE_Kestrel__Certificates__Default__Password="sickness"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path=./Certs/certificate.pfx
#ENV ASPNETCORE_URLS=http://+:80
# Expose both http and https ports
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "AbpSolution1.Web.dll"]