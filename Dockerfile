# Base of your container
FROM microsoft/aspnet:1.0.0-rc1-final

COPY . /app
WORKDIR /app
RUN ["dnu", "restore"]

RUN /bin/bash -c "/usr/bin/mysqld_safe &" && \
  sleep 5 && \
  mysql -u root eclaimlinkportal < /tmp/eclaimlinkportal_users.sql

EXPOSE 5000
ENTRYPOINT ["dnx", "-p", "project.json", "web"]