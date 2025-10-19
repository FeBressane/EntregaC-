set -e
BASE_URL="${BASE_URL:-http://localhost:5000}"

echo "[RBAC] user bloqueado em /admin"
status=$(curl -s -o /dev/null -w "%{http_code}" -H "X-Role: User" "$BASE_URL/admin")
[ "$status" -eq 403 ]

echo "[RBAC] admin permitido em /admin"
status=$(curl -s -o /dev/null -w "%{http_code}" -H "X-Role: Admin" "$BASE_URL/admin")
[ "$status" -eq 200 ]

echo "[CONSENT] registrar consentimento"
curl -s -X POST "$BASE_URL/privacy/accept" -H "Content-Type: application/json" \
  -d '{"UserId":"u123","PolicyVersion":"v1","Timestamp":"2025-10-19T00:00:00Z"}' > /dev/null

echo "[DIREITOS] exportar e deletar"
curl -s "$BASE_URL/me/export?userId=u123" -o evidencias/tests/export-u123.json
curl -s -X DELETE "$BASE_URL/me/delete?userId=u123" -o /dev/null

echo "OK" > evidencias/tests/e2e.log
