FROM node:18-alpine

WORKDIR /app

COPY package.json .

RUN npm install

RUN npm i -g serve

COPY . .

ARG APP_API_URL
ENV APP_API_URL=$APP_API_URL

RUN npm run build

EXPOSE 3000

CMD [ "serve", "-s", "dist" ]