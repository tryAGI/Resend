dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/resend/resend-openapi/main/resend.yaml
autosdk generate openapi.yaml \
  --namespace Resend \
  --clientClassName ResendClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
