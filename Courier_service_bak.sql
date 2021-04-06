PGDMP     :                    y            Courier_service    13.2    13.2 5    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                        0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16394    Courier_service    DATABASE     n   CREATE DATABASE "Courier_service" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
 !   DROP DATABASE "Courier_service";
                postgres    false                       0    0    DATABASE "Courier_service"    COMMENT     U   COMMENT ON DATABASE "Courier_service" IS 'Courier service database for course work';
                   postgres    false    3073            �            1259    16433    AspNetRoleClaims    TABLE     �   CREATE TABLE public."AspNetRoleClaims" (
    "Id" integer NOT NULL,
    "RoleId" character varying NOT NULL,
    "ClaimType" character varying,
    "ClaimValue" character varying
);
 &   DROP TABLE public."AspNetRoleClaims";
       public         heap    postgres    false            �            1259    16415    AspNetRoles    TABLE     �   CREATE TABLE public."AspNetRoles" (
    "Id" character varying NOT NULL,
    "Name" character varying(256),
    "NormalizedName" character varying(256),
    "ConcurrencyStamp" character varying
);
 !   DROP TABLE public."AspNetRoles";
       public         heap    postgres    false            �            1259    16445    AspNetUserClaims    TABLE     �   CREATE TABLE public."AspNetUserClaims" (
    "Id" integer NOT NULL,
    "UserId" character varying NOT NULL,
    "ClaimType" character varying,
    "ClaimValue" character varying
);
 &   DROP TABLE public."AspNetUserClaims";
       public         heap    postgres    false            �            1259    16455    AspNetUserLogins    TABLE     �   CREATE TABLE public."AspNetUserLogins" (
    "LoginProvider" character varying(128) NOT NULL,
    "ProviderKey" character varying(128) NOT NULL,
    "ProviderDisplayName" character varying,
    "UserId" character varying NOT NULL
);
 &   DROP TABLE public."AspNetUserLogins";
       public         heap    postgres    false            �            1259    16465    AspNetUserRoles    TABLE     |   CREATE TABLE public."AspNetUserRoles" (
    "UserId" character varying NOT NULL,
    "RoleId" character varying NOT NULL
);
 %   DROP TABLE public."AspNetUserRoles";
       public         heap    postgres    false            �            1259    16480    AspNetUserTokens    TABLE     �   CREATE TABLE public."AspNetUserTokens" (
    "UserId" character varying NOT NULL,
    "LoginProvider" character varying(128) NOT NULL,
    "Name" character varying(128) NOT NULL,
    "Value" character varying
);
 &   DROP TABLE public."AspNetUserTokens";
       public         heap    postgres    false            �            1259    16423    AspNetUsers    TABLE     �  CREATE TABLE public."AspNetUsers" (
    "Id" character varying NOT NULL,
    "UserName" character varying(256),
    "NormalizedUserName" character varying(256),
    "Email" character varying(256),
    "NormalizedEmail" character varying(256),
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" character varying,
    "SecurityStamp" character varying,
    "ConcurrencyStamp" character varying,
    "PhoneNumber" character varying,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" timestamp without time zone,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL
);
 !   DROP TABLE public."AspNetUsers";
       public         heap    postgres    false            �            1259    16403    Client    TABLE     $  CREATE TABLE public."Client" (
    "Id" bigint NOT NULL,
    "FName" character varying(20) NOT NULL,
    "SName" character varying(20) NOT NULL,
    "Patronymic" character varying(20),
    "Deleted" boolean NOT NULL,
    "AspName" character varying NOT NULL,
    "Phone" character varying
);
    DROP TABLE public."Client";
       public         heap    postgres    false            �            1259    16410    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            �            1259    16431    aspnetroleclaims_id_seq    SEQUENCE     �   ALTER TABLE public."AspNetRoleClaims" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.aspnetroleclaims_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    206            �            1259    16443    aspnetuserclaims_id_seq    SEQUENCE     �   ALTER TABLE public."AspNetUserClaims" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.aspnetuserclaims_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    208            �            1259    16399    client_clientid_seq    SEQUENCE     |   CREATE SEQUENCE public.client_clientid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.client_clientid_seq;
       public          postgres    false    201                       0    0    client_clientid_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.client_clientid_seq OWNED BY public."Client"."Id";
          public          postgres    false    200            N           2604    16406 	   Client Id    DEFAULT     p   ALTER TABLE ONLY public."Client" ALTER COLUMN "Id" SET DEFAULT nextval('public.client_clientid_seq'::regclass);
 <   ALTER TABLE public."Client" ALTER COLUMN "Id" DROP DEFAULT;
       public          postgres    false    200    201    201            �          0    16433    AspNetRoleClaims 
   TABLE DATA           W   COPY public."AspNetRoleClaims" ("Id", "RoleId", "ClaimType", "ClaimValue") FROM stdin;
    public          postgres    false    206   *E       �          0    16415    AspNetRoles 
   TABLE DATA           [   COPY public."AspNetRoles" ("Id", "Name", "NormalizedName", "ConcurrencyStamp") FROM stdin;
    public          postgres    false    203   GE       �          0    16445    AspNetUserClaims 
   TABLE DATA           W   COPY public."AspNetUserClaims" ("Id", "UserId", "ClaimType", "ClaimValue") FROM stdin;
    public          postgres    false    208   dE       �          0    16455    AspNetUserLogins 
   TABLE DATA           m   COPY public."AspNetUserLogins" ("LoginProvider", "ProviderKey", "ProviderDisplayName", "UserId") FROM stdin;
    public          postgres    false    209   �E       �          0    16465    AspNetUserRoles 
   TABLE DATA           ?   COPY public."AspNetUserRoles" ("UserId", "RoleId") FROM stdin;
    public          postgres    false    210   �E       �          0    16480    AspNetUserTokens 
   TABLE DATA           X   COPY public."AspNetUserTokens" ("UserId", "LoginProvider", "Name", "Value") FROM stdin;
    public          postgres    false    211   �E       �          0    16423    AspNetUsers 
   TABLE DATA           "  COPY public."AspNetUsers" ("Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount") FROM stdin;
    public          postgres    false    204   ?F       �          0    16403    Client 
   TABLE DATA           g   COPY public."Client" ("Id", "FName", "SName", "Patronymic", "Deleted", "AspName", "Phone") FROM stdin;
    public          postgres    false    201   8G       �          0    16410    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    202   �G                  0    0    aspnetroleclaims_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.aspnetroleclaims_id_seq', 1, false);
          public          postgres    false    205                       0    0    aspnetuserclaims_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.aspnetuserclaims_id_seq', 1, false);
          public          postgres    false    207                       0    0    client_clientid_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.client_clientid_seq', 1, true);
          public          postgres    false    200            R           2606    16414 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    202            P           2606    16409    Client client_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public."Client"
    ADD CONSTRAINT client_pkey PRIMARY KEY ("Id");
 >   ALTER TABLE ONLY public."Client" DROP CONSTRAINT client_pkey;
       public            postgres    false    201            \           2606    16437 $   AspNetRoleClaims pk_aspnetroleclaims 
   CONSTRAINT     f   ALTER TABLE ONLY public."AspNetRoleClaims"
    ADD CONSTRAINT pk_aspnetroleclaims PRIMARY KEY ("Id");
 P   ALTER TABLE ONLY public."AspNetRoleClaims" DROP CONSTRAINT pk_aspnetroleclaims;
       public            postgres    false    206            U           2606    16993    AspNetRoles pk_aspnetroles 
   CONSTRAINT     \   ALTER TABLE ONLY public."AspNetRoles"
    ADD CONSTRAINT pk_aspnetroles PRIMARY KEY ("Id");
 F   ALTER TABLE ONLY public."AspNetRoles" DROP CONSTRAINT pk_aspnetroles;
       public            postgres    false    203            _           2606    16449 $   AspNetUserClaims pk_aspnetuserclaims 
   CONSTRAINT     f   ALTER TABLE ONLY public."AspNetUserClaims"
    ADD CONSTRAINT pk_aspnetuserclaims PRIMARY KEY ("Id");
 P   ALTER TABLE ONLY public."AspNetUserClaims" DROP CONSTRAINT pk_aspnetuserclaims;
       public            postgres    false    208            b           2606    16930 $   AspNetUserLogins pk_aspnetuserlogins 
   CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserLogins"
    ADD CONSTRAINT pk_aspnetuserlogins PRIMARY KEY ("LoginProvider", "ProviderKey");
 P   ALTER TABLE ONLY public."AspNetUserLogins" DROP CONSTRAINT pk_aspnetuserlogins;
       public            postgres    false    209    209            e           2606    16904 "   AspNetUserRoles pk_aspnetuserroles 
   CONSTRAINT     r   ALTER TABLE ONLY public."AspNetUserRoles"
    ADD CONSTRAINT pk_aspnetuserroles PRIMARY KEY ("UserId", "RoleId");
 N   ALTER TABLE ONLY public."AspNetUserRoles" DROP CONSTRAINT pk_aspnetuserroles;
       public            postgres    false    210    210            Y           2606    16744    AspNetUsers pk_aspnetusers 
   CONSTRAINT     \   ALTER TABLE ONLY public."AspNetUsers"
    ADD CONSTRAINT pk_aspnetusers PRIMARY KEY ("Id");
 F   ALTER TABLE ONLY public."AspNetUsers" DROP CONSTRAINT pk_aspnetusers;
       public            postgres    false    204            g           2606    16873 $   AspNetUserTokens pk_aspnetusertokens 
   CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserTokens"
    ADD CONSTRAINT pk_aspnetusertokens PRIMARY KEY ("UserId", "LoginProvider", "Name");
 P   ALTER TABLE ONLY public."AspNetUserTokens" DROP CONSTRAINT pk_aspnetusertokens;
       public            postgres    false    211    211    211            V           1259    16839 
   EmailIndex    INDEX     S   CREATE INDEX "EmailIndex" ON public."AspNetUsers" USING btree ("NormalizedEmail");
     DROP INDEX public."EmailIndex";
       public            postgres    false    204            Z           1259    17037    IX_AspNetRoleClaims_RoleId    INDEX     _   CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON public."AspNetRoleClaims" USING btree ("RoleId");
 0   DROP INDEX public."IX_AspNetRoleClaims_RoleId";
       public            postgres    false    206            ]           1259    16961    IX_AspNetUserClaims_UserId    INDEX     _   CREATE INDEX "IX_AspNetUserClaims_UserId" ON public."AspNetUserClaims" USING btree ("UserId");
 0   DROP INDEX public."IX_AspNetUserClaims_UserId";
       public            postgres    false    208            `           1259    16947    IX_AspNetUserLogins_UserId    INDEX     _   CREATE INDEX "IX_AspNetUserLogins_UserId" ON public."AspNetUserLogins" USING btree ("UserId");
 0   DROP INDEX public."IX_AspNetUserLogins_UserId";
       public            postgres    false    209            c           1259    16905    IX_AspNetUserRoles_RoleId    INDEX     ]   CREATE INDEX "IX_AspNetUserRoles_RoleId" ON public."AspNetUserRoles" USING btree ("RoleId");
 /   DROP INDEX public."IX_AspNetUserRoles_RoleId";
       public            postgres    false    210            S           1259    17020    RoleNameIndex    INDEX     �   CREATE UNIQUE INDEX "RoleNameIndex" ON public."AspNetRoles" USING btree ("NormalizedName") WHERE ("NormalizedName" IS NOT NULL);
 #   DROP INDEX public."RoleNameIndex";
       public            postgres    false    203    203            W           1259    16820    UserNameIndex    INDEX     �   CREATE UNIQUE INDEX "UserNameIndex" ON public."AspNetUsers" USING btree ("NormalizedUserName") WHERE ("NormalizedUserName" IS NOT NULL);
 #   DROP INDEX public."UserNameIndex";
       public            postgres    false    204    204            h           2606    17038 7   AspNetRoleClaims fk_aspnetroleclaims_aspnetroles_roleid    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetRoleClaims"
    ADD CONSTRAINT fk_aspnetroleclaims_aspnetroles_roleid FOREIGN KEY ("RoleId") REFERENCES public."AspNetRoles"("Id") ON DELETE CASCADE;
 c   ALTER TABLE ONLY public."AspNetRoleClaims" DROP CONSTRAINT fk_aspnetroleclaims_aspnetroles_roleid;
       public          postgres    false    2901    206    203            i           2606    16962 7   AspNetUserClaims fk_aspnetuserclaims_aspnetusers_userid    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserClaims"
    ADD CONSTRAINT fk_aspnetuserclaims_aspnetusers_userid FOREIGN KEY ("UserId") REFERENCES public."AspNetUsers"("Id") ON DELETE CASCADE;
 c   ALTER TABLE ONLY public."AspNetUserClaims" DROP CONSTRAINT fk_aspnetuserclaims_aspnetusers_userid;
       public          postgres    false    2905    204    208            j           2606    16948 7   AspNetUserLogins fk_aspnetuserlogins_aspnetusers_userid    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserLogins"
    ADD CONSTRAINT fk_aspnetuserlogins_aspnetusers_userid FOREIGN KEY ("UserId") REFERENCES public."AspNetUsers"("Id") ON DELETE CASCADE;
 c   ALTER TABLE ONLY public."AspNetUserLogins" DROP CONSTRAINT fk_aspnetuserlogins_aspnetusers_userid;
       public          postgres    false    209    204    2905            l           2606    16999 5   AspNetUserRoles fk_aspnetuserroles_aspnetroles_roleid    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserRoles"
    ADD CONSTRAINT fk_aspnetuserroles_aspnetroles_roleid FOREIGN KEY ("RoleId") REFERENCES public."AspNetRoles"("Id") ON DELETE CASCADE;
 a   ALTER TABLE ONLY public."AspNetUserRoles" DROP CONSTRAINT fk_aspnetuserroles_aspnetroles_roleid;
       public          postgres    false    210    2901    203            m           2606    16851 6   AspNetUserTokens fk_aspnetuserroles_aspnetusers_userid    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserTokens"
    ADD CONSTRAINT fk_aspnetuserroles_aspnetusers_userid FOREIGN KEY ("UserId") REFERENCES public."AspNetUsers"("Id") ON DELETE CASCADE;
 b   ALTER TABLE ONLY public."AspNetUserTokens" DROP CONSTRAINT fk_aspnetuserroles_aspnetusers_userid;
       public          postgres    false    211    2905    204            k           2606    16890 5   AspNetUserRoles fk_aspnetuserroles_aspnetusers_userid    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserRoles"
    ADD CONSTRAINT fk_aspnetuserroles_aspnetusers_userid FOREIGN KEY ("UserId") REFERENCES public."AspNetUsers"("Id") ON DELETE CASCADE;
 a   ALTER TABLE ONLY public."AspNetUserRoles" DROP CONSTRAINT fk_aspnetuserroles_aspnetusers_userid;
       public          postgres    false    204    2905    210            �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �   t   x�36��0N1M�5MN3�51�0�M4H3�MI61K5L356KN�v,.�K-	-N-
.�/J��t,-�H�+�LN�S+9��]|=\#�̼ͽ����L�\]�#��ݹb���� > {      �   �   x���͎�0 ���]JhKL�+T�WR l����f͊+n|�%�ؙ�w��7$Cb��T[}b8x�@�}vF��0���u==��ۏ;�&���>[WM-�֕e�����/�9�$�G2&e|����3d
����^��buY��ɬm'yAd:�$�$�"�t\��(7۴�D����5�>/��!&�.�e
Ejy�`���TEP1C���(>_iD���b`�����sN��8��PR�      �   N   x�3�0��ދM�]��ya�ņ;.��|a/P`�9@ ���i�)�y�9�E%�ez%���F�\1z\\\ � $U      �      x������ � �     