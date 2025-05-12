FROM node:24-alpine AS base

RUN corepack enable

WORKDIR /app
COPY . .

RUN pnpm install --frozen-lockfile

EXPOSE 5173

CMD ["pnpm", "run", "dev", "--host"]